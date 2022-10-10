import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-cadastrar-candidatos',
  templateUrl: './cadastrar-candidatos.component.html',
  styleUrls: ['./cadastrar-candidatos.component.css']
})
export class CadastrarCandidatosComponent implements OnInit {

  nomeCandidato: String = "";
  nomeVice: String = "";
  subtitle: String = "";

  CadastrarCandidatos() {
    this.http.post("https://localhost:7237/api/Candidato", 
    {Nome: this.nomeCandidato, 
     NomeVice: this.nomeVice,
     Legenda: this.subtitle}).subscribe(response => {

      console.log("Recebido!");
      this.nomeCandidato = "";
      this.nomeVice = "";
      this.subtitle = "";

    }, error => {
      console.log(error);
    });
  }

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
  }

}