using System.Xml.Serialization;

namespace XMLSerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Company company = new Company()
            {
                Id = 12,
                Name = "Sirket Company",
                IsActive = true,

                Addresses = new List<Address>() {
                    new Address
                    {
                    Id=1,
                    Description="Beşiktaş",
                    City="İstanbul",
                    Country="Türkiye",
                    Priority=1
                    },
                    new Address
                    {
                        Id=2,
                        Description="Kızılay",
                        City="Ankara",
                        Country="Türkiye",
                        Priority=2
                    }
                }
            };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Company));
            //StreamWriter'ın içine dosya yolumuzu ve oluşturmak istediğimiz dosya adını yazalım.
            StreamWriter streamWriter = new StreamWriter(@"C:\Dosyalarım\XmlDosyam.xml");
            xmlSerializer.Serialize(streamWriter, company);
            streamWriter.Close();
        }
    }
}