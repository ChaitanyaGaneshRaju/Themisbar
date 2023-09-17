import { Component } from '@angular/core';

@Component({
  selector: 'app-individual-view-details-individual-view-detail-practice-exams',
  templateUrl: './individual-view-detail-practice-exams.component.html',
  styleUrls: ['./individual-view-detail-practice-exams.component.css']
})
export class IndividualViewDetailPracticeExamsComponent {
  practiceExams = Array.apply(null, Array(224)).map(function(){return {
    examName: 'MBE Baseline Exam (100)',
    completed: '03/03/2023',
    questions: 100,
    correct: Math.floor(Math.random() * 100) + 1,
    score: Math.floor(Math.random() * 100) + 1,
    average: Math.floor(Math.random() * 100) + 1,
  }})

  rowChange(event:any){
    console.log(event)
  }

}
