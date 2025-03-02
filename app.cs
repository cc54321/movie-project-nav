.App {
  text-align: center;
}

.App-logo {
  height: 40vmin;
  pointer-events: none;
}

@media (prefers-reduced-motion: no-preference) {
  .App-logo {
    animation: App-logo-spin infinite 20s linear;
  }
}

.App-header {
  background-color: #282c34;
  min-height: 100vh;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: flex-start;
  font-size: calc(10px + 2vmin);
  color: white;
}

.App-link {
  color: #61dafb;
}

@keyframes App-logo-spin {
  from {
    transform: rotate(0deg);
  }
  to {
    transform: rotate(360deg);
  }
}

/* New CSS Here */

.nav-layout {
	width: 100%;
	display: flex;
	flex-direction: column;
	align-items: center;
}

.nav-bar {
	display: flex;
	flex-direction: row;
	justify-content: space-between;
	width: 70%;
}

.movie-layout {
	display: flex;
	flex-direction: row;
	width: 100%;
	justify-content: space-between;
}

.movie-sidebar {
	flex: 1;
	display: flex;
	flex-direction: column;
	margin: 10px;
}

.movie-content {
	flex: 2;
}

a {
	color: white
}

.movie-list {
	overflow-y: scroll;
	max-height: 80vh;
}

.movie-list-card {
	border: 1px solid white;
	margin: 10px;
	padding: 20px;
} 