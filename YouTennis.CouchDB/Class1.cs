using LoveSeat;
using LoveSeat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTennis.DAL
{
    public class Class1
    {
        private const string DB_NAME = "youtennis";
        private CouchClient _client;
        public class FakePOCO : IBaseObject
        {
            public FakePOCO()
            {
                Children = new List<ChildPOCO>();
            }
            public string Id { get; set; }

            public string Rev { get; set; }

            public string Type { get { return "FakePOCO"; } }

            public List<ChildPOCO> Children { get; set; }
            public string Name { get; internal set; }
            public int Value { get; internal set; }
        }

        public Class1()
        {
            _client = new CouchClient("admin","lnzldn");
        }

        public class ChildPOCO
        {
            public string Title { get; set; }
            public DateTime Time { get; set; }
        }

        public void SaveDoc()
        {
            var db = _client.GetDatabase(DB_NAME);
            CouchRepository<FakePOCO> rep = new CouchRepository<FakePOCO>(db);

           
            FakePOCO fp = new FakePOCO() { Id="P1", Name = "Pippo", Value = 10 };
            fp.Children.Add(new ChildPOCO() { Time = DateTime.Now, Title = "AAA" });

            fp.Children.Add(new ChildPOCO() { Time = DateTime.Now, Title = "BBB" });

            rep.Save(fp);
        }

        public void Basics()
        {
         
            var db = _client.GetDatabase(DB_NAME);

            var result=db.GetAllDocuments();
            //// set default design doc (not required)
            //db.SetDefaultDesignDoc("docs");

            //// get document by ID
            //Document myDoc = db.GetDocument("12345");


            //// get document by ID (strongly typed POCO version)
            //FakePOCO myObj = db.GetDocument<FakePOCO>("12345");
        }

        public void Views()
        {
           
            var db = _client.GetDatabase(DB_NAME);
            // get view results
            var results = db.View<FakePOCO>("view_name");

            // get view results with parameters
            var options = new ViewOptions();
            options.StartKey.Add("Atlanta");
            options.EndKey.Add("Washington");

            var results2 = db.View<FakePOCO>("view_name", options);

            // loop through strongly typed results
            foreach (var item in results.Items)
            {
                // do something 

            }
        }

        public void ComplexViews()
        {
          
            var db = _client.GetDatabase(DB_NAME);
            var options = new ViewOptions();
            // generate ["foo"] startkey parameter
            options.StartKey.Add("foo");
            // generate ["foo",{},{}] endkey parameter
            //options.EndKey.Add("foo", CouchValue.Empty, CouchValue.Empty);

            var results = db.View<FakePOCO>("view_name", options);

            // loop through strongly typed results
            foreach (var item in results.Items)
            {
                // do something 

            }
        }
        }
}
