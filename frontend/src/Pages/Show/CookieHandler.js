import Cookies from 'universal-cookie';

function setCookies(TitelVoorstelling) {
    const cookies = new Cookies(document.cookies);
    cookies.set(TitelVoorstelling, document.getElementById('SelectedRang').value + ";" + document.getElementById('NumberTickets').value,{ path: '/Winkelmand' });
}

export default setCookies