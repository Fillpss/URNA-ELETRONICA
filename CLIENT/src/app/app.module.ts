import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { HomeComponent } from './home/home.component';
import { CadastrarCandidatosComponent } from './cadastrar-candidatos/cadastrar-candidatos.component'; 
import { AppRotasModule } from './app-rotas/app-rotas.module';
import { FormsModule } from '@angular/forms';
import { ExcluirCandidatoComponent } from './excluir-candidato/excluir-candidato.component';
import { VotarComponent } from './votar/votar.component';
import { ApuracaoComponent } from './apuracao/apuracao.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CadastrarCandidatosComponent,
    ExcluirCandidatoComponent,
    VotarComponent,
    ApuracaoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    AppRotasModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
