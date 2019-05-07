function PreviewImage(file, image) {
    if (file.files && file.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            image.attr('src', e.target.result);
        }
        reader.readAsDataURL(file.files[0]);
    }
}
function PreviewImageAndHref(file, image, a) {
    if (file.files && file.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            image.attr('src', e.target.result);
            a.attr('href', e.target.result);
        }
        reader.readAsDataURL(file.files[0]);
    }
}
function ValidImageType(file) {
    //Check Image Type
    var ext = file.val().split('.').pop().toLowerCase();
    if ($.inArray(ext, ['gif', 'png', 'jpg', 'jpeg']) != -1) {
        return true;
    }
        return false;
}
function DisplayFileExtension(file) {

    //Give Font Amesome for File extension
    var ext = file.split('.').pop().toLowerCase();
    if ($.inArray(ext, ['rar', 'zip', '7z', 'czip', 'pak']) != -1) {
        return "fa fa-file-archive-o fa-lg color_rar";
    }
    if ($.inArray(ext, ['pcm', 'wav', 'aiff', 'mp3', 'acc', 'flac', 'wma', 'alac']) != -1) {
        return "fa fa-file-audio-o fa-lg color_audio";
    }
    if ($.inArray(ext, ['xls', 'xlt', 'xlm', 'xlsz', 'xltx', 'xltm', 'xlsb', 'xla', 'xlam', 'xll', 'xlw', 'xlsx']) != -1) {
        return "fa fa-file-excel-o fa-lg color_excel";
    }
    if ($.inArray(ext, ['jpg', 'jpeg', 'jfif', 'jpeg 2000', 'exif', 'tiff', 'gif', 'bmp', 'png', 'ppm', 'pgm', 'pbm', 'pnm', 'webp', 'hdr', 'bat', 'bpg', 'svg', '3d', 'cgm']) != -1) {
        return "fa fa-file-image-o fa-lg color_image";
    }
    if ($.inArray(ext, ['webm', 'mkv', 'flv', 'mpeg', 'mpeg-4', 'vob', 'ogv', 'ogg', 'gifv', 'mng', 'avi', 'mov', 'wmv', 'yuv', 'rm', 'rmvb', 'asf', 'amv', 'mp4', 'mp4g', 'mpv', 'mpg', 'm2v', 'mpeg', 'm4v', 'svi', '3gp', 'mxf', 'roq', 'nsv', 'flv', 'f4v', 'f4p', 'f4a', 'f4b']) != -1) {
        return "fa fa-file-movie-o fa-lg color_video";
    }
    if ($.inArray(ext, ['pdf']) != -1) {
        return "fa fa-file-pdf-o fa-lg color_pdf";
    }
    if ($.inArray(ext, ['pptx', 'pptm', 'ppt', 'potx', 'pot', 'ppsx', 'ppsm', 'pps', 'ppam', 'ppa']) != -1) {
        return "fa fa-file-powerpoint-o fa-lg color_ppt";
    }
    if ($.inArray(ext, ['txt', 'html', 'htm']) != -1) {
        return "fa fa-file-text-o fa-lg color_text";
    }
    if ($.inArray(ext, ['doc', 'docx', 'odt']) != -1) {
        return "fa fa-file-word-o fa-lg color_word";
    }
    return "fa fa-file-o fa-lg color_none";
}
function DisplayDate(date) {
    //Process Date from SQL to HTML
    var result = "";
    if (date != null) {
        var jdate = date.slice(0, 10).split('-');
        result = jdate[0] + '-' +jdate[1] + '-' + jdate[2];  //MM dd yyyy
    }
    else
        result = "yyyy-mm-dd";

    if (result == "01-01-0001") {
        result = "yyyy-mm-dd";
    }

    return result;
}

function DeleteRowbyColumnValue(table, c_index, value) {
    //table must with tr   . like $("#tableid tr")
    var found = 0;
    table.each(function () {
        var c_value = $(this).find('td:eq(' + c_index + ')').text();
        if (c_value == value) {
            $(this).remove();
            found = 1;
            return false;
        }
    });
    if (found == 0) {
        alert("No Found : " + value);
    }
}
//Get Row Index
function GetRowNumber(editBtn) {
    var num = $(editBtn).closest('tr').index();
    return num;
}
//EditColTable($("#tbbody"), 1, 3, "<button class='btn btn-default')> Haha</button>");
function EditColTable(tbody, rownumber, colnumber, value) {
    var CCol = $(tbody).find('tr:nth-child(' + rownumber + ') td:nth-child(' + colnumber + ')').html(value);
}

function Star() {
    $(".star").append("<i style=color:red>*</i>");
}

function SetDisactiveBackground(isactive) {
    if (isactive == 0) {
        return activecolor = '#ff8080';
    }
    else {
        return activecolor = '';
    }
}
//isCheckBox($("#chktype"));
function isCheckBox(chk) {
    if ($(chk).is(":checked")) {
        return 1;
    }
    else {
        return 0;
    }
}

function DeactiveisCheckBox(chk) {
    if ($(chk).is(":checked")) {
        return 0;
    }
    else {
        return 1;
    }
}
//response get from return JSON
function JsonArraySpliter(response) {
    var data = eval("(" + response + ")");
    var arrdata = new Array();
    arrdata = data;
    return arrdata;
}
//GetRadioButton($("[name=rdotype]"));
//Need attribute Value
function GetRadioButton(rdo) {
    var v = "";
    $(rdo).each(function (index) {
        if (($(this).prop('tagName') == "INPUT") && $(this).attr("value") && ($(this).attr("type") == "radio")) {
            if ($(this).is(":checked")) {
                v = $(this).val();
                return;
            }
        }
    });
    return v;
}
//SetRadioButton($("[name=rdotype]"),"c");
//Need attribute Value
function SetRadioButton(rdo, val) {
    $(rdo).each(function (index) {
        if (($(this).prop('tagName') == "INPUT") && $(this).attr("value") && ($(this).attr("type") == "radio")) {
            if ($(this).val() == val) {
                $(this).iCheck('check');
            }
        }
    });
}

//isEmail("asdf@gmail.com");
function isEmail(email) {
    var pattern = new RegExp(/^(("[\w-+\s]+")|([\w-+]+(?:\.[\w-+]+)*)|("[\w-+\s]+")([\w-+]+(?:\.[\w-+]+)*))(@((?:[\w-+]+\.)*\w[\w-+]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][\d]\.|1[\d]{2}\.|[\d]{1,2}\.))((25[0-5]|2[0-4][\d]|1[\d]{2}|[\d]{1,2})\.){2}(25[0-5]|2[0-4][\d]|1[\d]{2}|[\d]{1,2})\]?$)/i);
    return pattern.test(email);
}

//isWebsite("www.google.com");
function isWebsite(textval) {
    var urlregex = new RegExp(
          "^(http:\/\/www.|https:\/\/www.|ftp:\/\/www.|www.){1}([0-9A-Za-z]+\.)");
    return urlregex.test(textval);
}

//Remove string from text
function ReString(value, from, to) {
    var ret = value.replace(from, to);
    return ret;
}

//Base64.encode(string);
//Base64.decode(encodedString);
var Base64 = {
    _keyStr: "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=",
    encode: function (e) { var t = ""; var n, r, i, s, o, u, a; var f = 0; e = Base64._utf8_encode(e); while (f < e.length) { n = e.charCodeAt(f++); r = e.charCodeAt(f++); i = e.charCodeAt(f++); s = n >> 2; o = (n & 3) << 4 | r >> 4; u = (r & 15) << 2 | i >> 6; a = i & 63; if (isNaN(r)) { u = a = 64 } else if (isNaN(i)) { a = 64 } t = t + this._keyStr.charAt(s) + this._keyStr.charAt(o) + this._keyStr.charAt(u) + this._keyStr.charAt(a) } return t },
    decode: function (e) { var t = ""; var n, r, i; var s, o, u, a; var f = 0; e = e.replace(/[^A-Za-z0-9+/=]/g, ""); while (f < e.length) { s = this._keyStr.indexOf(e.charAt(f++)); o = this._keyStr.indexOf(e.charAt(f++)); u = this._keyStr.indexOf(e.charAt(f++)); a = this._keyStr.indexOf(e.charAt(f++)); n = s << 2 | o >> 4; r = (o & 15) << 4 | u >> 2; i = (u & 3) << 6 | a; t = t + String.fromCharCode(n); if (u != 64) { t = t + String.fromCharCode(r) } if (a != 64) { t = t + String.fromCharCode(i) } } t = Base64._utf8_decode(t); return t },
    _utf8_encode: function (e) { e = e.replace(/rn/g, "n"); var t = ""; for (var n = 0; n < e.length; n++) { var r = e.charCodeAt(n); if (r < 128) { t += String.fromCharCode(r) } else if (r > 127 && r < 2048) { t += String.fromCharCode(r >> 6 | 192); t += String.fromCharCode(r & 63 | 128) } else { t += String.fromCharCode(r >> 12 | 224); t += String.fromCharCode(r >> 6 & 63 | 128); t += String.fromCharCode(r & 63 | 128) } } return t },
    _utf8_decode: function (e) { var t = ""; var n = 0; var r = c1 = c2 = 0; while (n < e.length) { r = e.charCodeAt(n); if (r < 128) { t += String.fromCharCode(r); n++ } else if (r > 191 && r < 224) { c2 = e.charCodeAt(n + 1); t += String.fromCharCode((r & 31) << 6 | c2 & 63); n += 2 } else { c2 = e.charCodeAt(n + 1); c3 = e.charCodeAt(n + 2); t += String.fromCharCode((r & 15) << 12 | (c2 & 63) << 6 | c3 & 63); n += 3 } } return t }
}
//For iCheck
//CheckBoxiCheckGroup("typeaccess");
function CheckBoxiCheckGroup(name) {
    var chks = $("[name=" + name + "]");
    if (chks.prop('tagName') == "INPUT" && chks.attr("type") == "checkbox") {
        chks.on('ifClicked', function (event) {
            chks.iCheck('uncheck');
            $(this).iCheck('check');
        });
    }
    else {
        alert("Wrong Tag or Type in Attritude Name = "+name);
    }
}
//CheckBoxGroup("typeaccess");
function CheckBoxGroup(name) {
    var chks = $("[name=" + name + "]");
    if (chks.prop('tagName') == "INPUT" && chks.attr("type") == "checkbox") {
        chks.change(function () {
            chks.prop('checked', false);
            $(this).prop('checked', true);
        });
    }
    else {
        alert("Wrong Tag or Type in Attritude Name = " + name);
    }
}

//isNumber(123);isNumber("123");
//Check is Number
function isNumber(num) {
    return $.isNumeric(num);
}

function GetColorGroup(num) {
    if ((num % 2) == 0)
        return "#f1f1f1";
    return "#ffffff";
}
