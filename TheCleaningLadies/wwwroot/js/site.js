// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Calender CSS by http://colorhunt.co/c/8184 and https://dribbble.com/shots/2407357-Calendar%60
var app = {
    settings: {
      container: $('.calendar'),
      calendar: $('.front'),
      days: $('.weeks span'),
      form: $('.back'),
      input: $('.back input'),
      buttons: $('.back button')
    },
  
    init: function() {
      instance = this;
      settings = this.settings;
      this.bindUIActions();
    },
  
    swap: function(currentSide, desiredSide) {
      settings.container.toggleClass('flip');
  
      currentSide.fadeOut(900);
      currentSide.hide();
      desiredSide.show();
  
    },
  
    bindUIActions: function() {
      settings.days.on('click', function(){
        instance.swap(settings.calendar, settings.form);
        settings.input.focus();
      });
  
      settings.buttons.on('click', function(){
        instance.swap(settings.form, settings.calendar);
      });
    }
  }
  
  app.init();