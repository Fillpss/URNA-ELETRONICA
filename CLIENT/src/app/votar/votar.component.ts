import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-votar',
  templateUrl: './votar.component.html',
  styleUrls: ['./votar.component.css']
})
export class VotarComponent implements OnInit {

  candidatos: any;


  BuscarCandidatos() {
    this.http.get("https://localhost:7237/api/Candidato").subscribe(response => {
      this.candidatos = response;
    }, error => {
      console.log(error);
    });
  }

  Votar(id: Number) {
    this.http.post("https://localhost:7237/api/Voto", 
    {CandidatoId: id}).subscribe(response => {
      console.log("Recebido!");
    }, error => {
      console.log(error);
    });
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.BuscarCandidatos();
  }

}
