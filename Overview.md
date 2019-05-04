# Parking Lot Accountability
#
### Parker Eastman
#
#### 03/02/2019
#
People follow people.  The organization of mass population centers is no new concept; cities allow for the consolidation of resources.  Urban sprawl has become a household term describing the expansion of populations surrounding cities, and as the numbers surrounding a city increase, the infrastructure within the city tends to struggle to maintain operability.  With the saturated resources, it’s no wonder why it’s seldom an easy task finding parking within a metropolitan area.  Having worked in a city, Boston, I’ve personally dealt with the frustration of traveling to a lot or garage, only to find it’s at full occupancy.  As a former security guard at a popular garage, I’m also familiar with the need to continually expend resources to count spots as a means of dispelling unhappy patrons.
#
The solution to the all-to-prominent “parking problem” is network connected sensors that relay parking data to people seeking spots within a city.  The user interface would consist of a list of lots and whether there are any spots available.  If a user selected the lot, the app would produce metadata noting the name of the lot, exact coordinates, a ratio of spots taken to spots available, cost, etc.  The initial application would be offered more as a proof of concept, than as a practical solution to parking problems.  Further implementations would contain a mapping function, or potentially be incorporated as a feature of more popular mapping services.
#
Starting with the physical interface, initial design will be based on an Arduino Uno board.  A laser break relay will serve as the sensor, although it could just as easily be swapped with another sensor providing similar effects, such as an inductor coil.  Two laser diodes will be mounted on the outsides of the entry/exit lanes; on the insides, phototransistors will be mounted, connected to the microcontroller within a central conduit.  When a strong enough light source is focused on the photo transistors, the circuit is “on”.  When the beam is broken, and the laser energy is not detected, the change in state will signal to the microcontroller, and an increment or decrement will be applied to a control number, depending on whether a car entered or exited the premised, respectively.  
#
Network connectivity will be a huge factor in developing this system.  As a solution, a W5100 Ethernet shield has been selected.  The shield will be affixed to the Arduino, allowing for rudimentary network communications.  An HTTP “POST” request will be made to the server, which will modify the number of cars in the lot.  Development in these phases will rely largely on the Arduino’s serial interface, on a packet analyzer such as Wireshark, and on a TCP/IP interface such as Netcat, to troubleshoot and correct each respective phase.
#
The “POST” requests serve as an integral part of this project.  The core functionality of this app will reside with the number of cars passed by these methods.  The database itself will be simple in implementation.  The only number being regularly modified should be the number of cars in the lot, although the number of spots total may be modified by parking lot administrators.   Among these values, name of lot, location, and other pertinent metadata will be stored.  In a separate database, usernames and passwords will be stored for the parking lot administrators to have control over their modifiable data.  
#
For the app itself, it will consist of a user and an administrator interface.  For a user, a location can be entered and nearby lots will be presented.  Each lot will display whether there are spots available.  Upon selection, all pertinent lot data will be supplied to the user.  In a location field, the user can select data for use by a separate mapping application, as that implementation is outside of the scope of the prototype.  The administrator interface will consist of a login.  After authentication, data such as the lot name, the total number of spaces, the price, and the number of cars may be modified.
#
Several different resources will be utilized throughout the duration of this project.  As the elements of the prototype have already been sourced, the first major hurdle will be in writing a program to increment/decrement the control number.  Fortunately, ample information can be found on the Arduino blog, and similar implementations on sites such as Instructables.com.   The same methods can be applied for applying network connectivity to the Arduino module.  RFCs will be referenced for proper construction of HTTP requests, and programs such as Netcat and HTTPClient will be used heavily in developing operability with the server.  Similar implementations have been made, Parker by Streetline and BestParking are two of them.  The provide mapping data, rates, and some statistical data, but they lack IoT connectivity that serves as the platform of this model.  







