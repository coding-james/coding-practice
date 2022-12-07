// Build the object / class
class Surgeon {
    // Constructor
    constructor(name, department) {
      this._name = name;
      this._department = department;
      this._remainingVacationDays = 20;
    }
  
    // Getters
    get name() {
      return this._name;
    }
  
    get department() {
      return this._department;
    }
  
    get remainingVacationDays() {
      return this._remainingVacationDays;
    }
    
    // Methods
    takeVacationDays(daysOff) {
        this._remainingVacationDays -= daysOff;
    }
  }
  
// Use the objects
  const surgeonRomero = new Surgeon('Francisco Romero', 'Cardiovascular');
  const surgeonJackson = new Surgeon('Ruth Jackson', 'Orthopedics');

console.log(surgeonRomero.name);
surgeonRomero.takeVacationDays(3);
console.log(surgeonRomero.remainingVacationDays);
