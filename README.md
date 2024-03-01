you need to import Nuget Plugin.ValidationRules
Create ViewModelExample1ViewModel
Create one custom rule class for custom validation IsNotNullOrEmptyRule impmenets IValidationRule<string>
back to codebehind bind the viewmodel in codebehid file
then check validation every proerty like Name, LastName and Email 
Xaml you have to bind the view model property
check validation for ButtonClick Events
if true then no error in your validation
if false that means soething is missing your enrty during put some value in the entry control..
