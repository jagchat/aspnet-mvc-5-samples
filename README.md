# ASP.NET MVC 5.x - Samples

### 01-Dropdownlist (binding, fullpostback)
* How to bind a dropdownlist to a viewmodel
* How to make an item selected in a dropdownlist through viewmodel
* How to do a full postback using dropdownlist (and retain the value selected after postback)
* How to retrieve the dropdownlist value posted through full postback (not through view model) using various ways


### 02-DropdownlistFor (binding, fullpostback)
* Exactly like 01 sample, but by using "DropdownlistFor" helper (instead of just "Dropdownlist" helper)
* How to make view model pick up posted values automatically (based on the control id and view model properties)

### 03-Dropdownlist (ajax POST, return string)
* Exactly like 02 sample, but by using "ajax" (not full page postback)
* adding necessary jquery scripts to work with microsoft ajax helpers
* enable "UnobtrusiveJavaScriptEnabled" setting in web.config 
* How to POST a form using partial postback (ajax), using dropdownlist together with "Ajax.BeginForm"
* How to return a string (from an action) during partial postback (ajax)
* How to update DOM after partial postback (ajax) with the data returned from server 
