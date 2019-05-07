function DisplayDateTimeToOnlyDate(date) {
    var result = "";
    if (date != null) {
        var jdate = date.slice(0, 10).split('-');
        result = jdate[0] + '-' + jdate[1] + '-' + jdate[2];
    }
    else result = "mm-dd-yyyy";
    if (result == "0001-01-01") {
        result = "mm-dd-yyyy";
    }
    return result;
}
function CurrentDate()
{
    var k = new Date();
    Day = ('0' + k.getDate()).slice(-2);
    Month = ('0' + k.getMonth() + 1).slice(-2);
    Year = k.getFullYear();
    return m = Year + "-" + Month + "-" + Day;
}
function MyDisplayDate(date) {
    var k = new Date(date);
    Day = ('0' + k.getDate()).slice(-2);
    Month = ('0' + k.getMonth() + 1).slice(-2);
    Year = k.getFullYear();
    return m = Year + "-" + Month + "-" + Day;
}
function FirstDayOfMonth(year, month)//month=0 and month=12 is December,1=january(simple)
{
    var FirstDay = new Date(year, month, 1);
    Day = ('0' + FirstDay.getDate()).slice(-2);
    Month = ('0' + FirstDay.getMonth()).slice(-2);
    Year = FirstDay.getFullYear();
    if (Month == 0) {
        Month = 12;
        Year = Year - 1;
    }
    return firstdayofmont = Year + "-" + Month + "-" + Day;
}
function LastDayOfMonth(year, month)//month=0 or month=12 is january,month=1 id February(start with 0)
{

    var LastDay = new Date(year, month, 0);
    Day = ('0' + LastDay.getDate()).slice(-2);
    Month = ('0' + (LastDay.getMonth() + 1)).slice(-2);
    Year = LastDay.getFullYear();
    return lastdayofmont = Year + "-" + Month + "-" + Day;
}
function getStringMonth(month) {
    month = month - 1;
    var months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];

    if (months[month] != null) {
        return months[month];
    } else {
        throw "Invalid Month No";
    }
}
function getNumericMonth(month1) {
    var months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
   
    return month1 = (months.indexOf(month1)) + 1;
   
}
function current_month() {
    var months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
    var date = new Date();
    m = date.getMonth();
    return months[m];
}
function current_year() {
    var date = new Date();
    return date.getFullYear();
}

function countDaysInMonth(month, year) {
    return m = new Date(year, month, 0).getDate();

}
function CountSundayInMonth(month, year)
{
    var date = new Date(month,year);
    var getTot = countDaysInMonth(date.getMonth(), date.getFullYear());
  
  var sun = new Array();
    var count = 0;
   for(var i=1;i<=getTot;i++)
    {
       var newDate = new Date(date.getFullYear(), date.getMonth()-1, i);
  
    if (newDate.getDay() == 0) {
            sun.push(i);
            count++;
        }
       
    }
    //console.log(sun);
   return count;
}
function splitStringMonthYear(datename)
{
    if (datename != null) {
    
        var months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
        var jdate = datename.slice(0, 8).split('-');
        result = jdate[0] + '-' + jdate[1];
       
            myresult = getNumericMonth(jdate[0]);
      
        return myresult;
    }
}