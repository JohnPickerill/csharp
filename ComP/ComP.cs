using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ComP {

    //[Guid("0F6C9D35-5AA4-41BE-BB3C-2A8F7AAB024C"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    //pblic interface IComClassExample {

    //}


    public class DocObj{
        public string uuid;
        public int size;
    }



    [ComVisible(true), Guid("DD231F40-47EB-4D37-BE01-FFD6C3BC20BB"), ClassInterface(ClassInterfaceType.AutoDispatch)]
    public class ComClassExample {

        DocsAPI docsApi = new DocsAPI("http://localhost:9995/", "STUB", "titleplan");
        


        [ComVisible(true)]
        public int Sum(int x, int y) {
            return x + y;
        }

         
        [ComVisible(true)]
        public string[] getTitles() {
            string[] titles = docsApi.get_titles();
            return titles;
        }


        [ComVisible(true)]
        public DocObj getObject(string title, string document, string version, string _object_no) {
            //Dictionary<string, object> _object = docsApi.get_object<Dictionary<string, object>>(title, document, version, _object_no);
            DocObj docObj = new DocObj();
            docObj.uuid = title;
            docObj.size = 1;
            return docObj;
        }

        public ComClassExample() {

        }
    }
}
