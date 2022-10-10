import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-apuracao',
  templateUrl: './apuracao.component.html',
  styleUrls: ['./apuracao.component.css']
})

export class ApuracaoComponent implements OnInit {

  candidatos: any = [];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get("https://localhost:7237/api/Candidato").subscribe(response => {
      this.candidatos = response;
      this.candidatos = this.candidatos.sort(function(pos: any, ant: any){
        if(ant.votos.length > pos.votos.length) return 1;
        if(ant.votos.length < pos.votos.length) return -1;
        return 0
      });
    }, error => {
      console.log(error);
    });
  }
}
