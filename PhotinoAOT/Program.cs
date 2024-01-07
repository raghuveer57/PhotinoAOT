

using PhotinoNET;

Thread thread = new Thread(() => {
    new PhotinoWindow()
               .SetTitle("Main Window")
               .RegisterWebMessageReceivedHandler(null)
               .SetUseOsDefaultSize(false)
               .SetWidth(600)
               .SetHeight(400)
               .Center()
               .Load(new Uri("http://google.com"))
               .WaitForClose();
});
thread.SetApartmentState(ApartmentState.STA);
thread.Start();


Console.ReadKey();
thread.Join();