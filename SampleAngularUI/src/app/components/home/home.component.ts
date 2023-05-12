import { Component, OnInit } from '@angular/core';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  public gridData: any[] = [];
  constructor(private studentService:StudentService) {

  }

  ngOnInit(): void {
    this.studentService.getStudents().subscribe((s) => {
      this.gridData = s.students;
    })
  }
}
