import { Component, OnInit } from '@angular/core';




@Component({
    selector: 'my-app',
    template: `
    <h1>{{title}}</h1>
    <nav>
        <a routerLink="/herodashboard" routerLinkActive="active">Dashboard</a>
        <a routerLink="/heroes" routerLinkActive="active">Heroes</a>
    </nav>
    <router-outlet></router-outlet>
`,
    styleUrls: ['app/app.component.css']
})
export class AppComponent {
    title = "Kyle's Website";
}
