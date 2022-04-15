using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Threading;

namespace CSInternal
{
    class SheetsIntegration
    {
        #region Variables
        static List<Dictionary<string, double>> buffer;
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "The experiment";
        static UserCredential credential;
        static SheetsService service;
        static string spreadsheetId = "1bPEpMpsme71gLLuz79Y2X9HidovggKSb2Zxe3aCaXmU";
        static string sheet;
        #endregion
        #region Methods
        public static int BufferSize { get=>buffer.Count; }
        public static void Initialize()
        {
            buffer = new List<Dictionary<string, double>>();
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(credPath, true)).Result;
            }
            // Create Google Sheets API service.
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            SpreadsheetsResource.GetRequest get = service.Spreadsheets.Get(spreadsheetId);
            get.IncludeGridData = true;
            var spreadSheet = get.Execute();
            SheetsIntegration.sheet = $"EX {spreadSheet.Sheets.Count}";//+1}";
            var sheet = new Sheet() { Properties = new SheetProperties() { Title = SheetsIntegration.sheet } };

            spreadSheet.Sheets.Add(sheet);

        }
        public static void AddRow()
        {
            if (Properties.Settings.Default.SheetsStorage)
            {
                var sensors = new Dictionary<string, double>();
                Form1.inst.GetSensors().ForEach(s => sensors.Add(((Sensor)s).Name, ((Sensor)s).CurrentReading));
                buffer.Add(sensors);
                if (sensors == null) return;
                if (((int)sensors["Time"]) % 10000 == 0)
                {
                    Thread t = new Thread(new ThreadStart(UploadBufferData));
                    t.Start();            
                }
            }

        }
        public static async void UploadBufferData()
        {
            var buff = new List<Dictionary<string, double>>(buffer);
            buffer.Clear();
            var sensors = buff.Last();
            var headers = service.Spreadsheets.Values.Get(spreadsheetId, $"{sheet}!A1:T1").ExecuteAsync().Result.Values.FirstOrDefault();
            if (headers.Count() < sensors.Count())
            {
                var newHeaders = sensors.Where(s => !headers.Contains(s.Key)).Select(s => s.Key);
                var range = $"{sheet}!{(char)('A' + headers.Where(o => o != null).Count())}1:{(char)('A' + headers.Where(o => o != null).Count() + newHeaders.Count())}1";
                var request = (service.Spreadsheets.Values.Update(new ValueRange() { Values = new List<IList<object>> { new List<object>(newHeaders) } }, spreadsheetId, range));
                request.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
                await request.ExecuteAsync();
                headers = service.Spreadsheets.Values.Get(spreadsheetId, $"{sheet}!A1:T1").ExecuteAsync().Result.Values.FirstOrDefault();
            }
            var vr = new List<IList<object>>();
            for (int i = 0; i < buff.Count; i++)
            {
                var values = new object[buff[i].Count()];
                for (int j = 0; j < values.Length; j++)
                {
                    values[j] = buff[i][headers[j].ToString()];
                }
                vr.Add(values.ToList());
            }
            var v = new ValueRange() { Values = vr };
            var rq = service.Spreadsheets.Values.Append(v, spreadsheetId, $"{sheet}!A:T");
            rq.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            try
            {
                rq.ExecuteAsync();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Relics
        /*
        static async Task AddData(string sensor, double value)
        {
            // Define request parameters.

            //get column index
            var headers = service.Spreadsheets.Values.Get(spreadsheetId, $"{sheet}!A1:J1").Execute().Values.FirstOrDefault();
            int columnIndex;
            if (headers.Contains(sensor))
            {
                columnIndex = headers.IndexOf(sensor);
            }
            else
            {
                columnIndex = headers.Where(o => o != null).Count();
                var request = (service.Spreadsheets.Values.Update(new ValueRange() { Values = new List<IList<object>> { new List<object> { sensor } } }, spreadsheetId, $"{sheet}!{(char)('A' + columnIndex)}1"));
                request.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
                request.Execute();
            }

            //row index
            var column = service.Spreadsheets.Values.Get(spreadsheetId, $"{sheet}!{(char)('A' + columnIndex)}:{(char)('A' + columnIndex)}").Execute().Values.Select(l => l[0]);
            int rowIndex = column.Count(r => r != null) + 1;


            //set range
            string range = $"{sheet}!{(char)('A' + columnIndex)}{rowIndex}";

            //append the value(needs to be changed to update!)
            try
            {
                var v = new ValueRange() { Values = new List<IList<object>> { new List<object> { value } } };
                var request = service.Spreadsheets.Values.Update(v, spreadsheetId, range);
                request.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
                request.Execute();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }*/
        #endregion
    }
}

