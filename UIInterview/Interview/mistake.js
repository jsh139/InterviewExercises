var object = {
    message: '',
    setupAlertMessageOnClick: function(elementSelector, optionalNumToAppend) {
      if(optionalNumToAppend){ //this could evaluate to false if they pass in 0
        this.message += optionalNumToAppend;
      }
      
      $(elementSelector).on('click', function(e){
        alert(this.message) // this will always be undefined because we are in an inner scope
      });
    }
};

