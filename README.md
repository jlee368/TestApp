Much of the work we do involves reading in files, parsing the data, performing calculations on the data and finally outputting that data in another document.
Attached is a solution which allows you to select an xml document of devices. The document is then parsed into an object of devices. Using that object and the dates you choose in the
user interface a new document is generated with devices falling within the dates you choose. You will need to implement the logic which selects the dates from the parsed dateList.Devices into a new list.
Then assign that list back into a new device list object. The file parsing and creation is already done for you. You only need to create the list of devices falling within the scannedOnAfter and
the scannedOnBefore dates. You are free to implement the creation of the list any way you choose. One hint is to use the methods in System.Linq to convert the array of devices to a list and then use
one of those methods to "FindAll" the matching devices. Another hint is to use a method in System.Array to "FindAll" the matching devices.

Included is a Devices.xml file. Use that file to feed into the application. Feel free to edit the xml file to suit your needs.

The logic for the program is housed in the code behind of the view. To access the code behind you will need to right click Form1.cs in the "Solution Explorer" view of Visual Studio. A context menu will appear.
Click "View Code" on the menu. You can also click to select the Form1.cs file in the "Solution Explorer" and press F7 to access the code behind of the view.

The minimum you need to do is get the filtering of devices working when the dates are changed in the user interface. Once completing the minimal requirements you are welcome to add
any additional functionality. You are also welcome to refactor the code to your liking or to the way you feel it should be written.