# telerik-aspnet-core-autorest


Run projects directly do not use IIS or IISExpress
Web runs at 5000
Api runs at 5001

Note until MS fixes the bug with launch settigns you need to delete the IISExpress property in the debug settings to force the Kestrel windows to startup

To configure for startup open the solution

Right click on the WebAutorestExample project and select properties
Click on Degbug panel and IF there is an IISExpress Profile set delete it
once deleted Profile should be WebAutorestExample, Launch "Project", Launch URL "http://localhost:5000"

save

Right click on the ApiExample project and select properties
Click on Degbug panel and IF there is an IISExpress Profile set delete it
once deleted Profile should be ApiExample, Launch "Project", Launch URL disabled, AppURL "http://localhost:5001"


save

Right click on the Solution select properties
set startup project to 
Multiple startup projects
set ApiExample  and WebAutorestExample to both start.

click ok.

build 

run

set breakpoint in the ApiExample Project ExampleController to see that the DataSourceRequest is not populated correctly.


