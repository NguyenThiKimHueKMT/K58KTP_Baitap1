using System;
using System.Web;
using Tholibrary; // namespace DLL thơ

public partial class api : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.ContentType = "application/json";

        string input = Request.Form["input"];

        PoetryMaker maker = new PoetryMaker();
        maker.InputText = input;
        string poem = maker.MakePoem();

        string json = "{\"poem\":\"" + poem.Replace("\r", "").Replace("\n", "\\n") + "\"}";
        Response.Write(json);
        Response.End();
    }
}
