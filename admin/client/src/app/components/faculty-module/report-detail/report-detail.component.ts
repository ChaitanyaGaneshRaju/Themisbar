import { Component } from '@angular/core';
import { FacultyIconsService } from 'src/app/services/faculty-icons.service';



@Component({
  selector: 'app-report-detail',
  templateUrl: './report-detail.component.html',
  styleUrls: ['./report-detail.component.css'],
})
export class ReportDetailComponent {

  constructor(private facultyIconsService: FacultyIconsService){
    this.facultyIconsService.load();
  }

  users = [
    {
      name: 'Pandora Knight',
      email: 'cras.dictum.ultricies@protonmail.com',
      phone: '1-336-669-6801',
      numberrange: 8,
      alphanumeric: 'MBJ11NMR2BV',
    },
    {
      name: 'Nathan Mckinney',
      email: 'netus@hotmail.edu',
      phone: '(805) 713-4557',
      numberrange: 7,
      alphanumeric: 'BBO89CGN3MR',
    },
    {
      name: 'Marshall Glass',
      email: 'elit.pellentesque@google.edu',
      phone: '(943) 718-2711',
      numberrange: 2,
      alphanumeric: 'RVL44HBC6SL',
    },
    {
      name: 'Isaac Merritt',
      email: 'massa.suspendisse@protonmail.org',
      phone: '(326) 552-0888',
      numberrange: 10,
      alphanumeric: 'HNE23IYO3TV',
    },
    {
      name: 'Evangeline Jarvis',
      email: 'sit@google.com',
      phone: '1-696-908-7578',
      numberrange: 8,
      alphanumeric: 'DNG68MZC5VU',
    },
    {
      name: 'Zahir Griffin',
      email: 'vel.est.tempor@hotmail.edu',
      phone: '1-482-211-2131',
      numberrange: 1,
      alphanumeric: 'YGD78VJM5EE',
    },
    {
      name: 'Salvador Ferrell',
      email: 'blandit@aol.net',
      phone: '(821) 524-6740',
      numberrange: 2,
      alphanumeric: 'VUJ37SJE0IS',
    },
    {
      name: 'Rachel Puckett',
      email: 'phasellus.elit@yahoo.couk',
      phone: '(443) 205-7666',
      numberrange: 4,
      alphanumeric: 'KMW24OWX4DE',
    },
    {
      name: 'Jordan Simmons',
      email: 'amet.consectetuer.adipiscing@icloud.net',
      phone: '(848) 686-9114',
      numberrange: 6,
      alphanumeric: 'VYQ61YWI5GQ',
    },
    {
      name: 'Bert Sykes',
      email: 'nullam.nisl@google.org',
      phone: '1-335-468-6757',
      numberrange: 8,
      alphanumeric: 'YUD73KOX8EM',
    },
    {
      name: 'Pandora Knight',
      email: 'cras.dictum.ultricies@protonmail.com',
      phone: '1-336-669-6801',
      numberrange: 8,
      alphanumeric: 'MBJ11NMR2BV',
    },
    {
      name: 'Nathan Mckinney',
      email: 'netus@hotmail.edu',
      phone: '(805) 713-4557',
      numberrange: 7,
      alphanumeric: 'BBO89CGN3MR',
    },
    {
      name: 'Marshall Glass',
      email: 'elit.pellentesque@google.edu',
      phone: '(943) 718-2711',
      numberrange: 2,
      alphanumeric: 'RVL44HBC6SL',
    },
    {
      name: 'Isaac Merritt',
      email: 'massa.suspendisse@protonmail.org',
      phone: '(326) 552-0888',
      numberrange: 10,
      alphanumeric: 'HNE23IYO3TV',
    },
    {
      name: 'Evangeline Jarvis',
      email: 'sit@google.com',
      phone: '1-696-908-7578',
      numberrange: 8,
      alphanumeric: 'DNG68MZC5VU',
    },
    {
      name: 'Zahir Griffin',
      email: 'vel.est.tempor@hotmail.edu',
      phone: '1-482-211-2131',
      numberrange: 1,
      alphanumeric: 'YGD78VJM5EE',
    },
    {
      name: 'Salvador Ferrell',
      email: 'blandit@aol.net',
      phone: '(821) 524-6740',
      numberrange: 2,
      alphanumeric: 'VUJ37SJE0IS',
    },
    {
      name: 'Rachel Puckett',
      email: 'phasellus.elit@yahoo.couk',
      phone: '(443) 205-7666',
      numberrange: 4,
      alphanumeric: 'KMW24OWX4DE',
    },
    {
      name: 'Jordan Simmons',
      email: 'amet.consectetuer.adipiscing@icloud.net',
      phone: '(848) 686-9114',
      numberrange: 6,
      alphanumeric: 'VYQ61YWI5GQ',
    },
    {
      name: 'Bert Sykes',
      email: 'nullam.nisl@google.org',
      phone: '1-335-468-6757',
      numberrange: 8,
      alphanumeric: 'YUD73KOX8EM',
    },
    {
      name: 'Pandora Knight',
      email: 'cras.dictum.ultricies@protonmail.com',
      phone: '1-336-669-6801',
      numberrange: 8,
      alphanumeric: 'MBJ11NMR2BV',
    },
    {
      name: 'Nathan Mckinney',
      email: 'netus@hotmail.edu',
      phone: '(805) 713-4557',
      numberrange: 7,
      alphanumeric: 'BBO89CGN3MR',
    },
    {
      name: 'Marshall Glass',
      email: 'elit.pellentesque@google.edu',
      phone: '(943) 718-2711',
      numberrange: 2,
      alphanumeric: 'RVL44HBC6SL',
    },
    {
      name: 'Isaac Merritt',
      email: 'massa.suspendisse@protonmail.org',
      phone: '(326) 552-0888',
      numberrange: 10,
      alphanumeric: 'HNE23IYO3TV',
    },
    {
      name: 'Evangeline Jarvis',
      email: 'sit@google.com',
      phone: '1-696-908-7578',
      numberrange: 8,
      alphanumeric: 'DNG68MZC5VU',
    },
    {
      name: 'Zahir Griffin',
      email: 'vel.est.tempor@hotmail.edu',
      phone: '1-482-211-2131',
      numberrange: 1,
      alphanumeric: 'YGD78VJM5EE',
    },
    {
      name: 'Salvador Ferrell',
      email: 'blandit@aol.net',
      phone: '(821) 524-6740',
      numberrange: 2,
      alphanumeric: 'VUJ37SJE0IS',
    },
    {
      name: 'Rachel Puckett',
      email: 'phasellus.elit@yahoo.couk',
      phone: '(443) 205-7666',
      numberrange: 4,
      alphanumeric: 'KMW24OWX4DE',
    },
    {
      name: 'Jordan Simmons',
      email: 'amet.consectetuer.adipiscing@icloud.net',
      phone: '(848) 686-9114',
      numberrange: 6,
      alphanumeric: 'VYQ61YWI5GQ',
    },
    {
      name: 'Bert Sykes',
      email: 'nullam.nisl@google.org',
      phone: '1-335-468-6757',
      numberrange: 8,
      alphanumeric: 'YUD73KOX8EM',
    },
    {
      name: 'Pandora Knight',
      email: 'cras.dictum.ultricies@protonmail.com',
      phone: '1-336-669-6801',
      numberrange: 8,
      alphanumeric: 'MBJ11NMR2BV',
    },
    {
      name: 'Nathan Mckinney',
      email: 'netus@hotmail.edu',
      phone: '(805) 713-4557',
      numberrange: 7,
      alphanumeric: 'BBO89CGN3MR',
    },
    {
      name: 'Marshall Glass',
      email: 'elit.pellentesque@google.edu',
      phone: '(943) 718-2711',
      numberrange: 2,
      alphanumeric: 'RVL44HBC6SL',
    },
    {
      name: 'Isaac Merritt',
      email: 'massa.suspendisse@protonmail.org',
      phone: '(326) 552-0888',
      numberrange: 10,
      alphanumeric: 'HNE23IYO3TV',
    },
    {
      name: 'Evangeline Jarvis',
      email: 'sit@google.com',
      phone: '1-696-908-7578',
      numberrange: 8,
      alphanumeric: 'DNG68MZC5VU',
    },
    {
      name: 'Zahir Griffin',
      email: 'vel.est.tempor@hotmail.edu',
      phone: '1-482-211-2131',
      numberrange: 1,
      alphanumeric: 'YGD78VJM5EE',
    },
    {
      name: 'Salvador Ferrell',
      email: 'blandit@aol.net',
      phone: '(821) 524-6740',
      numberrange: 2,
      alphanumeric: 'VUJ37SJE0IS',
    },
    {
      name: 'Rachel Puckett',
      email: 'phasellus.elit@yahoo.couk',
      phone: '(443) 205-7666',
      numberrange: 4,
      alphanumeric: 'KMW24OWX4DE',
    },
    {
      name: 'Jordan Simmons',
      email: 'amet.consectetuer.adipiscing@icloud.net',
      phone: '(848) 686-9114',
      numberrange: 6,
      alphanumeric: 'VYQ61YWI5GQ',
    },
    {
      name: 'Bert Sykes',
      email: 'nullam.nisl@google.org',
      phone: '1-335-468-6757',
      numberrange: 8,
      alphanumeric: 'YUD73KOX8EM',
    },
  ];

  // users = [];
}
