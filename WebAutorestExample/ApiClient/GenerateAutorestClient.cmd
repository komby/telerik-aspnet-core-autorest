#
# GenerateAutorestClient.cmd
#

#to run this you will need to install node.js  and autorest .   You also need to update your VS settings to not use the VS extensions version of node and instead use your installed version of node.
#you may need to also adjust the system path environment variables to point to your node install in C:\Program Files (x86)\nodejs  instead of the VS extensions version
# to install autorest you can run (npm install -g autorest) @see https://github.com/Azure/autorest   

#Note that you need a running endpoint to run this script against


 autorest -Input http://localhost:5001/api-docs/v1/swagger.json  -OutputDirectory AutorestClient -Namespace WebAutorestExample.ApiClient
