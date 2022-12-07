class HospitalEmployee {
  constructor(name) {
    this._name = name;
    this._remainingVacationDays = 20;
  }

  get name() {
    return this._name;
  }

  get remainingVacationDays() {
    return this._remainingVacationDays;
  }

  takeVacationDays(daysOff) {
    this._remainingVacationDays -= daysOff;
  }

  static generatePassword() {
    return Math.floor(Math.random() * 10000);
  }
}

//Nurse inherits from HospitalEmployee and adds a new property
class Nurse extends HospitalEmployee {
  constructor(name, certifications) {
    super(name); //inherits from the superclass
    this._certifications = certifications;
  }

  get certifications() {
    return this._certifications;
  }

  addCertification(newCertification) {
    this._certifications.push(newCertification);
  }

}

const nurseOlynyk = new Nurse('Olynyk', ['Trauma', 'Pediatrics']);
nurseOlynyk.takeVacationDays(5); //Nurse will inherit getters and methods also
console.log(nurseOlynyk.remainingVacationDays);
nurseOlynyk.addCertification('Genetics'); //add a certification
console.log(nurseOlynyk.certifications);